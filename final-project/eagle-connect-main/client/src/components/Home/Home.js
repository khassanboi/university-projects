import React, { useState, useEffect } from "react";
import { Container } from "@material-ui/core";
import useStyles from "./styles";

import { useSelector, useDispatch } from "react-redux";
import { getUsers } from "../../actions/users";
import { getApplications } from "../../actions/applications";

import Applications from "../../components/Applications/Applications";
import Application from "../../components/Application/Application";
import Form from "../../components/Form/Form";
import Auth from "../Auth/Auth";

const Home = () => {
  const [currentId, setCurrentId] = useState(0);
  const classes = useStyles();
  const dispatch = useDispatch();
  const applications = useSelector((state) => state.applications);

  useEffect(() => {
    dispatch(getApplications());
  }, [dispatch]);

  useEffect(() => {
    dispatch(getUsers());
  }, [currentId, dispatch]);

  let user;
  let isSignedIn = false;

  if (JSON.parse(localStorage.getItem("profile"))) {
    user = JSON.parse(localStorage.getItem("profile")).result;
    isSignedIn = true;
  }

  const getApplication = (id) => applications.find((app) => app.userId === id);

  const checkApplication = (id) => (getApplication(id) ? true : false);

  switch (isSignedIn) {
    case false:
      return (
        <Container>
          <Auth />
        </Container>
      );
  }
  switch (user.isManager) {
    case true:
      return (
        <Container>
          <Applications setCurrentId={setCurrentId} />
        </Container>
      );

    case false:
      switch (checkApplication(user._id)) {
        case true:
          return (
            <Container>
              <Application application={getApplication(user._id)} user={user} />
            </Container>
          );
        case false:
          return (
            <Container>
              <Form
                className={classes.form}
                currentId={currentId}
                setCurrentId={setCurrentId}
              />
            </Container>
          );
      }
  }
};

export default Home;
