import { AxiosResponse } from "axios";
import qs from 'qs';

import RequestService from '../../../services/requests';
import EndPoints from '../../../Constants/endpoints';

import Cookies from 'universal-cookie';
const cookies = new Cookies();
var accessToken = cookies.get("AccessToken", { path: '/' });
let config = {
    headers: {
      authorization: "Bearer " + accessToken,
    },
  };
export function createCategoryRequest(categoryForm) {
    const formData = new FormData();

    Object.keys(categoryForm).forEach(key => {
        formData.append(key, categoryForm[key]);
    });

    return RequestService.axios.post(EndPoints.category, formData, config);
}

export function getCategoriesRequest(query) {
    return RequestService.axios.get(EndPoints.category, {
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}

export function getAllCategoriesRequest() {
    return RequestService.axios.get(EndPoints.categories);
}

export function UpdateCategoryRequest(categoryForm) {
    const formData = new FormData();

    Object.keys(categoryForm).forEach(key => {
        formData.append(key, categoryForm[key]);
    });

    return RequestService.axios.put(EndPoints.categoryId(categoryForm.categoryId ?? - 1), formData, config);
}

export function DisableCategoryRequest(categoryId) {
    return RequestService.axios.delete(EndPoints.categoryId(categoryId),config);
}