import {LayoutChange} from './layoutChange';
import {Authorization} from "./authorization";

export class BaseState {
    
    private _ChangeLayoutMode : LayoutChange;
    public get ChangeLayoutMode() : LayoutChange {
        return this._ChangeLayoutMode;
    }
    public set ChangeLayoutMode(v : LayoutChange) {
        this._ChangeLayoutMode = v;
    }


    
    private _auth : Authorization;
    public get auth() : Authorization {
        return this._auth;
    }
    public set auth(v : Authorization) {
        this._auth = v;
    }
    
    
}