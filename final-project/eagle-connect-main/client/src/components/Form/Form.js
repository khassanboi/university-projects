import React, { useState, useEffect } from "react";
import { Grid, TextField, Button, MenuItem, Paper } from "@material-ui/core";
import { useDispatch, useSelector } from "react-redux";

import useStyles from "./styles";
import { createApplication } from "../../actions/applications";

const Form = ({ currentId, setCurrentId }) => {
  const [applicationData, setApplicationData] = useState({
    userId: JSON.parse(localStorage.getItem("profile")).result._id,
    phone: "",
    uni: "",
    yos: "",
    purpose: "",
  });
  const application = useSelector((state) =>
    currentId ? state.applications.find((data) => data._id === currentId) : null
  );
  const dispatch = useDispatch();
  const classes = useStyles();

  useEffect(() => {
    if (application) setApplicationData(application);
  }, [application]);

  const clear = () => {
    setCurrentId(0);
    setApplicationData({
      userId: "",
      phone: "",
      uni: "",
      yos: "",
      purpose: "",
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (currentId === 0) {
      dispatch(createApplication(applicationData));
      clear();
    }
    // else {
    //   dispatch(updateApplication(currentId, applicationData));
    //   clear();
    // }
  };

  return (
    <Paper className={classes.paper} maxWidth="100%">
      <form
        autoComplete="off"
        noValidate
        className={`${classes.root} ${classes.form}`}
        onSubmit={handleSubmit}
      >
        <Grid
          container
          rowSpacing={2}
          columnSpacing={2}
          wrap="nowrap"
          sx={{ mx: 2 }}
        >
          <TextField
            name="phone"
            variant="outlined"
            label="Phone Number"
            fullWidth
            value={applicationData.phone}
            onChange={(e) =>
              setApplicationData({ ...applicationData, phone: e.target.value })
            }
          />
          <TextField
            select
            name="uni"
            id="uni"
            variant="outlined"
            labelId="uniLbl"
            label="University Name"
            fullWidth
            value={applicationData.uni}
            onChange={(e) =>
              setApplicationData({ ...applicationData, uni: e.target.value })
            }
          >
            <MenuItem
              value={"Westminster International University in Tashkent"}
            >
              Westminster International University in Tashkent
            </MenuItem>
            <MenuItem
              value={
                "Management Development Institute of Singapore in Tashkent"
              }
            >
              Management Development Institute of Singapore in Tashkent
            </MenuItem>
            <MenuItem value={"Ajou University in Tashkent"}>
              Ajou University in Tashkent
            </MenuItem>
            <MenuItem value={"Akfa University"}>Akfa University</MenuItem>
            <MenuItem value={"Amity University in Tashkent"}>
              Amity University in Tashkent
            </MenuItem>
            <MenuItem value={"British Management University"}>
              British Management University
            </MenuItem>
            <MenuItem value={"Cambridge International University"}>
              Cambridge International University
            </MenuItem>
            <MenuItem value={"Inha University in Tashkent"}>
              Inha University in Tashkent
            </MenuItem>
            <MenuItem value={"National University of Uzbekistan"}>
              National University of Uzbekistan
            </MenuItem>
            <MenuItem value={"Team University in Tashkent"}>
              Team University in Tashkent
            </MenuItem>
            <MenuItem value={"TMC Institute in Tashkent"}>
              TMC Institute in Tashkent
            </MenuItem>
            <MenuItem value={"Turin Polytechnic University in Tashkent"}>
              Turin Polytechnic University in Tashkent
            </MenuItem>
            <MenuItem value={"Webster University in Tashkent"}>
              Webster University in Tashkent
            </MenuItem>
            <MenuItem value={0}>Other</MenuItem>
          </TextField>

          <TextField
            select
            id="yos"
            name="yos"
            variant="outlined"
            label="Year of Study"
            fullWidth
            value={applicationData.yos}
            onChange={(e) =>
              setApplicationData({ ...applicationData, yos: e.target.value })
            }
          >
            <MenuItem value={1}>1 - Foundation</MenuItem>
            <MenuItem value={2}>2</MenuItem>
            <MenuItem value={3}>3</MenuItem>
          </TextField>
        </Grid>
        <Grid container rowSpacing={2} columnSpacing={3} sy={{ p: 4 }}>
          <TextField
            multiline
            minRows={4}
            id="purpose"
            name="purpose"
            variant="outlined"
            label="Purpose of Participation (min 100 words)"
            fullWidth
            value={applicationData.purpose}
            onChange={(e) =>
              setApplicationData({
                ...applicationData,
                purpose: e.target.value,
              })
            }
          />
        </Grid>

        <Grid
          container
          rowSpacing={2}
          columnSpacing={3}
          sy={{ p: 4 }}
          className={classes.buttonGrid}
        >
          <Button
            className={classes.buttonSubmit}
            variant="contained"
            size="large"
            type="submit"
            style={{
              backgroundColor: "#006DB6",
              padding: "18px 36px",
              margin: "0 7px",
              fontSize: "16px",
              color: "white",
            }}
          >
            {currentId
              ? `Edit ${application.firstName}'s Information`
              : "Submit Application"}
          </Button>
        </Grid>
      </form>
    </Paper>
  );
};

export default Form;
