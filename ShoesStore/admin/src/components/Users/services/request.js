import { AxiosResponse } from "axios";
import qs from 'qs';
import RequestService from '../../../services/requests';
import EndPoints from '../../../Constants/endpoints';
import Cookies from 'universal-cookie';
const cookies = new Cookies();
export function getUsersRequest(query) {
    var accessToken = cookies.get("AccessToken", { path: '/' });
    return RequestService.axios.get(EndPoints.user, {
        headers: {
            authorization: "Bearer " + accessToken,
          },
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}