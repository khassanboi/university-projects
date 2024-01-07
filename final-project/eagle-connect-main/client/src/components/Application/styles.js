import { makeStyles } from "@material-ui/core/styles";

export default makeStyles(() => ({
  form: {
    marginBottom: "10px",
    borderRadius: 20,
  },
  paper: {
    backgroundColor: "#F5F5F5",
    color: "#000000",
    borderRadius: 10,
    padding: "20px 30px",
  },
  fieldName: {
    fontWeight: "bold",
    marginTop: "10px",
    display: "inline-block",
    fontSize: "1rem",
  },
  fieldValue: {
    display: "inline-block",
    fontSize: "1rem",
    marginLeft: "10px",
  },
  fieldValueEssay: {
    display: "inline-block",
    fontSize: "1rem",
    textAlign: "justify",
    marginLeft: "10px",
  },
}));
