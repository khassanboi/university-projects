import React from "react";
import { DataGrid, GridToolbar } from "@mui/x-data-grid";
import { Fab } from "@material-ui/core";
import { Save } from "@material-ui/icons";
import { useDispatch, useSelector } from "react-redux";
import { updateApplication } from "../../actions/applications";

const Applications = () => {
  const applications = useSelector((state) => state.applications);
  const users = useSelector((state) => state.users);
  const dispatch = useDispatch();
  const getUserData = (id) => {
    if (users[0]) return users.find((user) => user._id === id);
  };

  const handleSubmit = async (e, params) => {
    e.preventDefault();
    const { eagleId, status, phone, uni, yos, purpose, id, userId } =
      params.row;
    await dispatch(
      updateApplication(id, {
        eagleId,
        status,
        phone,
        uni,
        yos,
        purpose,
        userId,
      })
    );

    console.log(params.row);
  };

  const columns = [
    { field: "id", headerName: "Id", width: 50, hide: true },
    { field: "eagleId", headerName: "Eagle ID", width: 100 },
    { field: "userId", headerName: "userId", width: 50, hide: true },
    { field: "email", headerName: "Email Address", width: 150 },
    { field: "firstName", headerName: "First Name", width: 100 },
    { field: "lastName", headerName: "Last Name", width: 100 },
    { field: "phone", headerName: "Phone Number", width: 150, editable: true },
    {
      field: "uni",
      headerName: "University Name",
      width: 200,
      editable: true,
      type: "singleSelect",
      valueOptions: [
        "Westminster International University in Tashkent",
        "Management Development Institute of Singapore in Tashkent",
        "Ajou University in Tashkent",
        "Akfa University",
        "Amity University in Tashkent",
        "British Management University",
        "Cambridge International University",
        "Inha University in Tashkent",
        "National University of Uzbekistan",
        "Team University in Tashkent",
        "TMC Institute in Tashkent",
        "Turin Polytechnic University in Tashkent",
        "Webster University in Tashkent",
      ],
    },
    { field: "yos", headerName: "Year of Study", width: 80, editable: true },
    { field: "purpose", headerName: "Essay", width: 200, editable: true },
    {
      field: "status",
      headerName: "Program Status",
      width: 300,
      editable: true,
      type: "singleSelect",
      valueOptions: [
        "Application Pending",
        "Application Accepted - Payment Not Received",
        "Application Accepted - Payment Received",
        "Application Rejected",
        "Placed To Job Offer",
        "Visa Approved",
        "Visa Denied",
        "Cancelled",
      ],
    },
    {
      field: "Save",
      renderCell: (rowValue) => (
        <Fab
          color="primary"
          onClick={(e) => {
            handleSubmit(e, rowValue);
          }}
        >
          <Save />
        </Fab>
      ),
    },
    // {
    //   field: "Delete",
    //   renderCell: (rowValue) => (
    //     <Button
    //       variant="contained"
    //       style={{
    //         backgroundColor: "#B3525A",
    //         color: "white",
    //       }}
    //       onClick={() => {
    //         dispatch(deleteApplication(rowValue.row.id));
    //       }}
    //     >
    //       Delete
    //     </Button>
    //   ),
    // },
  ];

  const rows = applications.map((row) => ({
    id: row._id,
    eagleId: row.eagleId,
    status: row.status,
    userId: row.userId,
    firstName:
      applications[0] && users[0] ? getUserData(row.userId).firstName : "",
    lastName:
      applications[0] && users[0] ? getUserData(row.userId).lastName : "",
    email: applications[0] && users[0] ? getUserData(row.userId).email : "",
    phone: row.phone,
    uni: row.uni,
    yos: row.yos,
    purpose: row.purpose,
  }));

  return (
    <div style={{ height: 700, width: "100%" }}>
      <DataGrid
        rows={rows}
        columns={columns}
        pageSize={50}
        rowsPerPageOptions={[50, 100, 150, 200]}
        height={500}
        experimentalFeatures={{ newEditingApi: true }}
        components={{ Toolbar: GridToolbar }}
        sx={{
          mt: 2.5,
          p: 2,
          backgroundColor: "background.paper",
          borderRadius: 2.5,
        }}
      />
    </div>
  );
};

export default Applications;
