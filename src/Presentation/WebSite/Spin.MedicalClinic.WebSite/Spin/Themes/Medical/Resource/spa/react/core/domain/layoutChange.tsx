import staticData from '../../config/config';

export class LayoutChange
{

    public constructor()
    {
        this.data = staticData.darkMode;
        this.rtlData = staticData.rtl;
        this.topMenu = staticData.topMenu;
        this.loading = false;
        this.rtlLoading = false;
        this.menuLoading = false;
        this.error = null;
    }

    private _data: boolean;
    public get data(): boolean {
        return this._data;
    }
    public set data(v: boolean) {
        this._data = v;
    }


    private _rtlData: boolean;
    public get rtlData(): boolean {
        return this._rtlData;
    }
    public set rtlData(v: boolean) {
        this._rtlData = v;
    }


    private _topMenu: boolean;
    public get topMenu(): boolean {
        return this._topMenu;
    }
    public set topMenu(v: boolean) {
        this._topMenu = v;
    }


    private _loading: boolean;
    public get loading(): boolean {
        return this._loading;
    }
    public set loading(v: boolean) {
        this._loading = v;
    }



    private _rtlLoading: boolean;
    public get rtlLoading(): boolean {
        return this._rtlLoading;
    }
    public set rtlLoading(v: boolean) {
        this._rtlLoading = v;
    }



    private _menuLoading: boolean;
    public get menuLoading(): boolean {
        return this._menuLoading;
    }
    public set menuLoading(v: boolean) {
        this._menuLoading = v;
    }



    private _error: any;
    public get error(): any {
        return this._error;
    }
    public set error(v: any) {
        this._error = v;
    }
}