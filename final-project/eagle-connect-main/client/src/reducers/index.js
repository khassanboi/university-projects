import { combineReducers } from "redux";

import applications from "./applications";
import auth from "./auth";
import users from "./users";

export const reducers = combineReducers({ applications, users, auth });
