import { getRequest, postRequest } from "./Methods";

class User {
<<<<<<< Updated upstream
    
    Register(body){
        return postRequest('/register/Register', body);
    }  
    
=======
  Register(body) {
    return postRequest("/register/Register", body);
  }

  Login(body) {
    return postRequest("/login/Login", body);
  }
>>>>>>> Stashed changes
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
