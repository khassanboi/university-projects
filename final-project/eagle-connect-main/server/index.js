import express from "express";
import bodyParser from "body-parser";
import mongoose from "mongoose";
import cors from "cors";

import applicationRoutes from "./routes/applications.js";
import userRoutes from "./routes/users.js";

const app = express();

app.use(bodyParser.json({ limit: "30mb", extended: true }));
app.use(bodyParser.urlencoded({ limit: "30mb", extended: true }));
app.use(cors());

app.use("/applications", applicationRoutes);
app.use("/users", userRoutes);

app.get("/", (req, res) => {
  res.send("This is an API server for the Eagle Connect CRM");
});

const CONNECTION_URL =
  "mongodb+srv://khassanboi:khassanboi@cluster0.h11c6.mongodb.net/?retryWrites=true&w=majority";
const PORT = process.env.PORT || 2000;

mongoose
  .connect(CONNECTION_URL, { useNewUrlParser: true, useUnifiedTopology: true })
  .then(() =>
    app.listen(PORT, () =>
      console.log(`Server Running on Port: http://localhost:${PORT}`)
    )
  )
  .catch((error) => console.log(`${error} did not connect`));
