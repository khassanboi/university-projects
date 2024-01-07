import axios from "axios";

const applicationsUrl = "https://eagle-connect.herokuapp.com/applications";
const usersUrl = "https://eagle-connect.herokuapp.com/users";

export const fetchApplications = () => axios.get(applicationsUrl);
export const createApplication = (newApplication) =>
  axios.post(applicationsUrl, newApplication);
export const updateApplication = (id, updatedApplication) =>
  axios.patch(`${applicationsUrl}/${id}`, updatedApplication);
export const deleteApplication = (id) =>
  axios.delete(`${applicationsUrl}/${id}`);

export const getUsers = () => axios.get(usersUrl);
export const getUser = (id) => axios.get(`${usersUrl}/${id}`);
export const signIn = (formData) => axios.post(`${usersUrl}/signin`, formData);
export const signUp = (formData) => axios.post(`${usersUrl}/signup`, formData);
