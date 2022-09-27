import React, { useState } from 'react';
import { Link, NavLink, useHistory } from 'react-router-dom';
import { Form, Input, Button } from 'antd';
import { useDispatch, useSelector } from 'react-redux';
// eslint-disable-next-line import/no-extraneous-dependencies
import { FacebookOutlined, TwitterOutlined } from '@ant-design/icons';
import { AuthWrapper } from './style';
import { login } from '../../../../redux/authentication/actionCreator';
import { Checkbox } from '../../../../components/checkbox/checkbox';
import Heading from '../../../../components/heading/heading';
import { BaseState } from "../../../../core/domain/baseState";

const SignIn = () => {
  //const history = useHistory();
  const dispatch = useDispatch();
  const isLoading = useSelector<BaseState>(state => state.auth.loading);
  const [form] = Form.useForm();
  const [state, setState] = useState({
    checked: null
  });

  const handleSubmit = () => {
    setState({ ...state });
    dispatch(login(form));
  };

  const onChange = checked => {
    setState({ ...state, checked });
  };

  return (
    <AuthWrapper>

      <div className="auth-contents">
        <Form name="login" form={form} onFinish={handleSubmit} layout="vertical">
          <Heading as="h3">
            Ingresar al <span className="color-secondary">Administrador</span>
          </Heading>
          <Form.Item
            name="username"
            rules={[{ message: 'Por favor use su correo o usuario!', required: true }]}
            initialValue=""
            label="Usuario o correo"
          >
            <Input placeholder="Usuario o correo" />
          </Form.Item>
          <Form.Item name="password" initialValue="" label="Contraseña">
            <Input.Password placeholder="Contraseña" />
          </Form.Item>
          <div className="auth-form-action">
            <Checkbox onChange={onChange}>Mantenerse autenticado</Checkbox>
            <NavLink className="forgot-pass-link" to="/forgotPassword">
              Olvido su contraseña?
            </NavLink>
          </div>
          <Form.Item>
            <Button className="btn-signin" htmlType="submit" type="primary" size="large">
              {isLoading ? 'cargando...' : 'Sign In'}
            </Button>
          </Form.Item>  
        </Form>
      </div>
    </AuthWrapper>
  );
};

export default SignIn;
