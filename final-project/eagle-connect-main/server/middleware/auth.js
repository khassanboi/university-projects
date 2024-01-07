import jwt from "jsonwebtoken";

const auth = async (req, res, next) => {
  try {
    const token = req.headers.authorization.split("")[1];

    let decodedData;

    if (token) {
      decodedData = jwt.verify(token, "eagle2023");

      req.userId = decodedData?.id;
    }
  } catch (error) {
    console.log(error.message);
  }
};

export default auth;
