import { combineReducers } from "redux";
import { Action } from "./actions";


export  interface AccessToken{
    isFeatching:boolean,
    accessToken?:string,
}

export interface State{
    accessToken:AccessToken
}


const accessToken = (state:AccessToken = {isFeatching:false}, action:Action):AccessToken =>{
    switch(action.type){
        case "SET":
            return {...state, accessToken:action.accessToken};

        case "SET_FETCHING":
            return {...state, isFeatching:action.isFeatching}; 
        
        default:
            return state;
    }
};


export default combineReducers<State>({accessToken});