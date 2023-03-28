import logo from "./logo.svg";
import "./App.css";
import { useEffect } from "react";
import Customer from "./Layouts/Customer";

import { BrowserRouter, Routes, Route, NavLink } from "react-router-dom";
import Manager from "./Layouts/Manager";
import Login from "./Layouts/Login";
import Register from "./Layouts/Register";

function App() {
  return (
    <>
      {/* <Customer /> */}
      <BrowserRouter>
        <Routes>
          {/* <Route exact path="*" element={<Customer />} /> */}
          <Route exact path='*' element={<Manager />} />
          <Route exact path="/login" element={<Login />} />
          <Route exact path="/register" element={<Register />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
