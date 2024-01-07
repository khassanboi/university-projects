import bcrypt from "bcryptjs";
import jwt from "jsonwebtoken";

import User from "../models/userSchema.js";

export const signin = async (req, res) => {
  const { email, password } = req.body;
  try {
    const existingUser = await User.findOne({ email });

    if (!existingUser)
      return res.status(404).json({ message: "User does not exist!" });

    const isPasswordCorrect = await bcrypt.compare(
      password,
      existingUser.password
    );

    if (!isPasswordCorrect)
      return res.status(400).json({ message: "Invalid credentials!" });

    const token = jwt.sign(
      {
        email: existingUser.email,
        id: existingUser._id,
      },
      "eagle2023",
      { expiresIn: "1h" }
    );

    res.status(200).json({ result: existingUser, token });
  } catch (error) {
    res.status(500).json;
    ({ message: `Something went wrong: ${error.message}` });
  }
};

export const signup = async (req, res) => {
  const { email, password, confirmPassword, firstName, lastName } = req.body;

  try {
    const existingUser = await User.findOne({ email });

    if (existingUser)
      return res
        .status(400)
        .json({ message: "User with this email already exists!" });

    if (password !== confirmPassword)
      return res.status(400).json({ message: "Passwords do not match!" });

    const hashedPassword = await bcrypt.hash(password, 12);

    const result = await User.create({
      email,
      password: hashedPassword,
      firstName,
      lastName,
    });

    const token = jwt.sign(
      {
        email: result.email,
        id: result._id,
      },
      "eagle2023",
      { expiresIn: "1h" }
    );

    res.status(200).json({ result: result, token });
  } catch (error) {
    res.status(500).json;
    ({ message: `Something went wrong: ${error.message}` });
  }
};

export const getUser = async (req, res) => {
  const { id } = req.params;

  try {
    const user = await User.findById(id);

    res.status(200).json(user);
  } catch (error) {
    res.status(404).json({ message: error.message });
  }
};

export const getUsers = async (req, res) => {
  try {
    const users = await User.find();

    res.status(200).json(users);
  } catch (error) {
    res.status(404).json({ message: error.message });
  }
};
