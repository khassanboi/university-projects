import { nanoid, customAlphabet } from "nanoid";

export const generateId = () => {
  const nanoid = customAlphabet("12345678900", 5);
  return "EG" + nanoid();
};
