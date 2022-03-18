import {getAllBrandsRequest} from '../components/Brands/services/request'
import { getAllCategoriesRequest } from '../components/Categories/services/request';

export const getBrandsAsync = async (selectOptionsBrand) => {
    let data = await getAllBrandsRequest("");
    if (data)
    {            
        let brands = data.data;
        brands.map((item)=>{
           selectOptionsBrand.push({label:item.brandName, value:item.brandId})
        })
    }
    return (selectOptionsBrand)
}

export const getCategoriesAsync = async (selectOptionsCategory) => {
    let data = await getAllCategoriesRequest("");
    if (data)
    {            
        let categories = data.data;
        categories.map((item)=>{
            selectOptionsCategory.push({label:item.categoryName, value:item.categoryId})
        })
    }
    return (selectOptionsCategory)
}