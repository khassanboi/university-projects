import React from "react";
import { Box } from "@material-ui/core";

import { BrowserRouter, Routes, Route } from "react-router-dom";

import Navbar from "./components/Navbar/Navbar";
import Home from "./components/Home/Home";
import Auth from "./components/Auth/Auth";

const App = () => (
  <BrowserRouter>
    <Box fullWidth>
      <Navbar />
      <Routes>
        <Route path="/home" element={<Home />} />
        <Route path="/" element={<Auth />} />
      </Routes>
    </Box>
  </BrowserRouter>
);

export default App;
