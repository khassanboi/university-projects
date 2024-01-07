import { FETCH_ALL, CREATE, UPDATE, DELETE } from "../constants/actionTypes";

export default (applications = [], action) => {
  switch (action.type) {
    case FETCH_ALL:
      return action.payload;
    case CREATE:
      return [...applications, action.payload];
    case UPDATE:
      return applications.map((application) =>
        application._id === action.payload._id ? action.payload : application
      );
    case DELETE:
      return applications.filter(
        (application) => application._id !== action.payload
      );
    default:
      return applications;
  }
};
