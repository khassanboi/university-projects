import { FETCH_ALL, CREATE, UPDATE /*DELETE*/ } from "../constants/actionTypes";

import * as api from "../api/index.js";

export const getApplications = () => async (dispatch) => {
  try {
    const { data } = await api.fetchApplications();

    dispatch({ type: FETCH_ALL, payload: data });
  } catch (error) {
    console.log(error.message);
  }
};

export const createApplication = (application) => async (dispatch) => {
  try {
    const { data } = await api.createApplication(application);

    dispatch({ type: CREATE, payload: data });
  } catch (error) {
    console.log(error.message);
  }
};

// FOR FUTURE USE

export const updateApplication = (id, application) => async (dispatch) => {
  try {
    const { data } = await api.updateApplication(id, application);

    dispatch({ type: UPDATE, payload: data });
  } catch (error) {
    console.log(error.message);
  }
};

// export const deleteApplication = (id) => async (dispatch) => {
//   try {
//     await api.deleteApplication(id);

//     dispatch({ type: DELETE, payload: id });
//   } catch (error) {
//     console.log(error.message);
//   }
// };
