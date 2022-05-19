import { AxiosResponse } from "axios";
import qs from 'qs';
import RequestService from '../../../services/requests';
import EndPoints from '../../../Constants/endpoints';
import Swal from 'sweetalert2';
import Cookies from 'universal-cookie';
let tokenInfo;
export function authenticate(loginForm){
    RequestService.axios
          .post(EndPoints.login,loginForm.formValues)
          .then(function (response) {
            tokenInfo = response.data;
            if(tokenInfo.role!="Admin"){
                
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'you do not have permission to access this website!',
                    showConfirmButton: true
                  });
            }
            else{
                const cookies = new Cookies();
                cookies.set("AccessToken", tokenInfo.accessToken, { path: '/' });
                cookies.set("FullName", tokenInfo.fullName, { path: '/' });
            }
          })
          .catch(function (error) {
            if (400 === error.response.status) {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'UserName or Password incorrect!',
                    showConfirmButton: true
                  });
              } else {
                return Promise.reject(error);
              }
          });
      }