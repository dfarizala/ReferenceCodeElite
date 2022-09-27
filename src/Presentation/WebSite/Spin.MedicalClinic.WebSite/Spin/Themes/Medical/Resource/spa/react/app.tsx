import React, { useEffect, useState, Component } from 'react';
import { hot } from 'react-hot-loader/root';
import { Provider, useSelector } from 'react-redux';
import { ThemeProvider } from 'styled-components';
import { HashRouter as Router, Redirect, Route } from 'react-router-dom';
import { ConfigProvider } from 'antd';
import "reflect-metadata";
import store from './redux/store';
//import Admin from './routes/admin';
import './static/css/style.css';
import config from './config/config';
import { BaseState } from "./core/domain/baseState"
import { LayoutChange } from './core/domain/layoutChange';
import Auth from './routes/auth';
import { DependencyInjectionInfrastructure } from './core/infrastructure/DependencyInjectionInfrastructure';
import { DependencyInjectionApplication } from './core/application/dependencyInjectionApplication';
import { DependencyInjectionDomain } from './core/domain/DependencyInjectionDomain';



const { theme } = config;


//Load DI
DependencyInjectionDomain.DependencyInjectionStartup();
DependencyInjectionInfrastructure.DependencyInjectionStartup();
DependencyInjectionApplication.DependencyInjectionStartup();




const ProviderConfig = () => {
  var layoutChange = useSelector<BaseState, LayoutChange>(state => {
    return state.ChangeLayoutMode;
  });

  const [path, setPath] = useState(window.location.pathname);

  
  useEffect(() => {
    let unmounted = false;
    if (!unmounted) {
      setPath(window.location.pathname);
    }
    // eslint-disable-next-line no-return-assign
    //return () => (unmounted = true);
  }, [setPath]);

  return (
    <ConfigProvider direction={layoutChange.rtlData ? 'rtl' : 'ltr'}>
      <ThemeProvider theme={{ ...theme, ...layoutChange }}>
        <Router >
          <Route path="/" component={Auth} />
        </Router>
      </ThemeProvider>
    </ConfigProvider>
  );  

};


export class App extends Component {
  render() {
    return (
      <Provider store={store}>
        <ProviderConfig />
      </Provider>
    );
  };
}



export default hot(App);