import { FETCH_ALL_USERS } from "../constants/actionTypes";

import * as api from "../api/index.js";

export const getUsers = () => async (dispatch) => {
  try {
    const { data } = await api.getUsers();
    dispatch({ type: FETCH_ALL_USERS, payload: data });
  } catch (error) {
    console.log(error.message);
  }
};
