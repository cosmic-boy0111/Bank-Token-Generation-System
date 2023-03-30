import { getRequest, postRequest } from "./Methods";

class User {
  Register(body) {
    return postRequest("/register/Register", body);
  }
  Login(body) {
    return postRequest("/login/Login", body);
  }

  getUser(body){
    return postRequest('/login/getUser',body);
  }


}

class Service {
  getServices() {
    return getRequest("/manager/allServices");
  }

  addService(body) {
    return postRequest("/manager/addService", body);
  }

  updateService(body) {
    return postRequest("/manager/updateService", body);
  }

  deleteService(body) {
    return postRequest("/manager/deleteService", body);
  }
}

export const Api = {
  user: new User(),
  service: new Service(),
};
