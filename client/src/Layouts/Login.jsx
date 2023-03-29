import React from "react";
import axios from "axios";
import "../Style/Login.css";
import { useState } from "react";

import Box from "@mui/material/Box";
import TextField from "@mui/material/TextField";
import { Button } from "@mui/material";
import { useNavigate } from "react-router-dom";

const Login = () => {
  const [user, setUser] = useState({
    Name: "",
    Password: "",
  });

  const navigate = useNavigate();

  const gotoRegister = () => {
    navigate(`/register`);
  };

  const onUserInput = (e) => {
    var name = e.target.name;
    var value = e.target.value;
    setUser({
      ...user,
      [name]: value,
    });
  };

  const handleLogin = () => {
    const data = {};

    axios
      .post("/api/login/Login", data)
      .then((response) => {})

      .catch((error) => {
        console.log(error);
      });
  };

  return (
    <div className="login_body">
      <div className="login_div">
        <h2 className="mb_1">Login</h2>
        <TextField
          id="standard-basic"
          label="User Name"
          variant="standard"
          style={{ width: "100%", marginBottom: "1rem" }}
          onChange={onUserInput}
        />
        <TextField
          id="standard-password-input"
          label="Password"
          type="password"
          autoComplete="current-password"
          variant="standard"
          style={{ width: "100%", marginBottom: "1rem" }}
          onChange={onUserInput}
        />

        <Button
          variant="contained"
          style={{ width: "100%", marginBottom: "1rem" }}
          onClick={handleLogin}
        >
          Login
        </Button>
        <Button variant="text" style={{ width: "100%" }} onClick={gotoRegister}>
          Register
        </Button>
      </div>
    </div>
  );
};

export default Login;
