import { makeStyles } from "@material-ui/core/styles";

export default makeStyles(() => ({
  appBar: {
    borderRadius: 10,
    width: "auto",
    margin: "20px 25px",
    display: "flex",
    flexDirection: "row",
    justifyContent: "start",
    alignItems: "center",
  },
  heading: {
    color: "rgba(0,183,255, 1)",
  },
  image: {
    margin: "10px 0",
    marginLeft: "15px",
    width: "12%",
    height: "auto",
  },
  form: {
    marginBottom: "10px",
    borderRadius: 20,
  },
}));
