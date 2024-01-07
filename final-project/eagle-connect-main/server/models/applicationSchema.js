import mongoose from "mongoose";

const applicationSchema = mongoose.Schema({
  id: { type: String },
  eagleId: { type: String, required: true },
  userId: { type: String, required: true },
  phone: { type: String, required: true },
  uni: {
    type: String,
    required: true,
    enum: [
      "Westminster International University in Tashkent",
      "Management Development Institute of Singapore in Tashkent",
      "Ajou University in Tashkent",
      "Akfa University",
      "Amity University in Tashkent",
      "British Management University",
      "Cambridge International University",
      "Inha University in Tashkent",
      "National University of Uzbekistan",
      "Team University in Tashkent",
      "TMC Institute in Tashkent",
      "Turin Polytechnic University in Tashkent",
      "Webster University in Tashkent",
    ],
  },
  yos: {
    type: Number,
    default: 1,
    min: 1,
    max: 3,
  },

  purpose: { type: String, required: true },
  status: {
    type: String,
    default: "Application Pending",
    required: true,
    enum: [
      "Application Pending",
      "Application Accepted - Payment Not Received",
      "Application Accepted - Payment Received",
      "Application Rejected",
      "Placed To Job Offer",
      "Visa Approved",
      "Visa Denied",
      "Cancelled",
    ],
  },
});

var ApplicationData = mongoose.model("ApplicationData", applicationSchema);

export default ApplicationData;
