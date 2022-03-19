import { AxiosResponse } from "axios";
import qs from 'qs';

import RequestService from '../../../services/requests';
import EndPoints from '../../../Constants/endpoints';

export function getUsersRequest(query) {
    return RequestService.axios.get(EndPoints.user, {
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}