import { ThunkAction, ThunkDispatch } from "redux-thunk";
import { AnyAction } from "redux";


export interface SetAction{
    type: "SET";
    accessToken: string;
}

export interface SetFetching{
    type: "SET_FETCHING";
    isFeatching : boolean;
}

//union type
export type Action = SetAction | SetFetching;


//Creation
export const set = (accessToken: string):SetAction => { 
    return {type: "SET", accessToken: accessToken};
};

export const isFetching = (isFetching: boolean):SetFetching => {
    return {type: "SET_FETCHING", isFeatching: isFetching};
};


export const login = (email:string, password: string): ThunkAction<Promise<void>, {},{}, AnyAction> => {
    return async (dispatch: ThunkDispatch<{}, {}, AnyAction>): Promise<void> =>{
        return new Promise<void>((resolve) => {
            dispatch(isFetching(true));
            console.log("login in progress");

            setTimeout(() => {
                dispatch(isFetching(false));
                console.log("login done");
                resolve();
            });
        });
    }
};
