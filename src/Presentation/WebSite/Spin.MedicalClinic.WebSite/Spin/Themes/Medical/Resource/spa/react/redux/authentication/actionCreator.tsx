import "reflect-metadata";
import { container } from "tsyringe";
import Cookies from 'js-cookie';
import actions from './actions';
import { useDispatch, useSelector } from 'react-redux';
import { ILoginApplication } from '../../core/domain/interfaces/application/iLoginApplication';
import { RequestLogin } from '../../core/domain/entity/security/requestLogin';
import { BaseState } from '../../core/domain/baseState';
import { FormInstance } from "antd";

const { loginBegin, loginSuccess, loginErr, logoutBegin, logoutSuccess, logoutErr } = actions;

const login = (form:FormInstance) => {
  
  return async dispatch => {
    try {
      dispatch(loginBegin());

      var securityApplication = container.resolve<ILoginApplication>("ISecurityApplication");
      var request = new RequestLogin();
      request.UserName = form.getFieldValue('username');
      request.Password = form.getFieldValue('password');

      console.log(request);

      var result = await securityApplication.Login(request);

      dispatch(loginSuccess(true));
      console.log(result);

      return true;

      /*
            setTimeout(() => {
              
              dispatch(loginSuccess(true));
              return false;//dispatch(loginSuccess(true));
            }, 10000);
            */
    } catch (err) {
      dispatch(loginErr(err));
    }

  };
};

const logOut = () => {
  return async dispatch => {
    try {
      dispatch(logoutBegin());
      Cookies.remove('logedIn');
      dispatch(logoutSuccess(null));
    } catch (err) {
      dispatch(logoutErr(err));
    }
  };
};

export { login, logOut };
