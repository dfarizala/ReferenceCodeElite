import React, { lazy, Suspense } from 'react';
import { Spin } from 'antd';
import { Switch, Route, Redirect } from 'react-router-dom';
import AuthLayout from '../container/profile/authentication/Index';

const Login = lazy(() => import('../container/profile/authentication/overview/SignIn'));
const ForgotPass = lazy(() => import('../container/profile/authentication/overview/ForgotPassword'));

const NotFound = () => {
  return <Redirect to="/" />;
};

const FrontendRoutes = () => {
  return (
    <Switch>
      <Suspense
        fallback={
          <div className="spin">
            <Spin />
          </div>
        }
      >
        <Route  path="/forgotPassword" component={ForgotPass} />
        <Route  path="/" component={Login} />
      </Suspense>
    </Switch>
  );
};

export default AuthLayout(FrontendRoutes);
