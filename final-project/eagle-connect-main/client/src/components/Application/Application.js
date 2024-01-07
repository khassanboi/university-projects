import React from "react";
import { Paper, Typography } from "@material-ui/core";
import useStyles from "./styles";

const Application = ({ application, user }) => {
  const classes = useStyles();

  return (
    <Paper className={classes.paper}>
      <Typography variant="h5">Application Details</Typography>

      <Typography variant="h6" className={classes.fieldName}>
        Eagle Id:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {application.eagleId}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        Program Status:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {application.status}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        First Name:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {user.firstName}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        Last Name:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {user.lastName}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        Phone Number:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {application.phone}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        University:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {application.uni}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        Year of Study:
      </Typography>
      <Typography variant="h6" className={classes.fieldValue}>
        {application.yos}
      </Typography>

      <br />
      <Typography variant="h6" className={classes.fieldName}>
        Essay:
      </Typography>
      <Typography variant="h6" className={classes.fieldValueEssay}>
        {application.purpose}
      </Typography>
    </Paper>
  );
};

export default Application;
