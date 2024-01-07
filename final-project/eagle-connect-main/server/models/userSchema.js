import mongoose from "mongoose";

const userSchema = mongoose.Schema({
  id: { type: String },
  firstName: { type: String, required: true },
  lastName: { type: String, required: true },
  password: { type: String, required: true },
  email: { type: String, required: true },
  isManager: { type: Boolean, required: true, default: false },
});

var UserData = mongoose.model("UserData", userSchema);

export default UserData;
