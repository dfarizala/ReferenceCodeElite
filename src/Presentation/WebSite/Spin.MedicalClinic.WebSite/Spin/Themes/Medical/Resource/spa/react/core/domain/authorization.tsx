export class Authorization{
    
    public constructor(){
        this._login = false;
    }

    private _login : boolean;
    public get login() : boolean {
        return this._login;
    }
    public set login(v : boolean) {
        this._login = v;
    }


    
    private _loading : boolean;
    public get loading() : boolean {
        return this._loading;
    }
    public set loading(v : boolean) {
        this._loading = v;
    }
    
    
}