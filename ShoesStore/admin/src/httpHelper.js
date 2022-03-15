import axios from "axios";
import { UrlBackEnd } from "./Constants/oidc-config";

const endpoint = UrlBackEnd;

export function get(url) {
    return axios.get(endpoint + url);
  }

export function put(url, body) {
    return axios.put(endpoint + url, body);
  }
  
  export function post(url, body) {
    return axios.post(endpoint + url, body);
  }
  
  export function del(url) {
    return axios.delete(endpoint + url);
  }