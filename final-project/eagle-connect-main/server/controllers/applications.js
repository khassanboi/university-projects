import express from "express";
import mongoose from "mongoose";

import ApplicationData from "../models/applicationSchema.js";

import { generateId } from "../tools/idGenerator.js";

const router = express.Router();

export const getApplications = async (req, res) => {
  try {
    const applications = await ApplicationData.find();

    res.status(200).json(applications);
  } catch (error) {
    res.status(404).json({ message: error.message });
  }
};

export const getApplication = async (req, res) => {
  const { id } = req.params;

  try {
    const application = await ApplicationData.findById(id);

    res.status(200).json(application);
  } catch (error) {
    res.status(404).json({ message: error.message });
  }
};

export const createApplication = async (req, res) => {
  const { userId, phone, uni, yos, purpose } = req.body;
  const eagleId = generateId();

  const newApplicationData = new ApplicationData({
    eagleId,
    userId,
    phone,
    uni,
    yos,
    purpose,
  });

  try {
    await newApplicationData.save();

    res.status(201).json(newApplicationData);
  } catch (error) {
    res.status(409).json({ message: error.message });
  }
};

export const updateApplication = async (req, res) => {
  const { id } = req.params;
  const { eagleId, phone, status, uni, yos, purpose, userId } = req.body;

  if (!mongoose.Types.ObjectId.isValid(id))
    return res.status(404).send(`No application with id: ${id}`);

  const updatedApplication = {
    eagleId,
    phone,
    uni,
    yos,
    purpose,
    userId,
    status,
    _id: id,
  };

  await ApplicationData.findByIdAndUpdate(id, updatedApplication, {
    new: true,
  });

  res.json(updatedApplication);
};

// FOR FUTURE USE

// export const deleteApplication = async (req, res) => {
//   const { id } = req.params;

//   if (!mongoose.Types.ObjectId.isValid(id))
//     return res.status(404).send(`No application with id: ${id}`);

//   await ApplicationData.findByIdAndRemove(id);

//   res.json({ message: "Application Data deleted successfully." });
// };

export default router;
