import React, { useState } from 'react';
import { Link, NavLink, useHistory } from 'react-router-dom';
import { Form, Input, Button } from 'antd';
import { AuthWrapper } from './style';
import Heading from '../../../../components/heading/heading';

const ForgotPassword = () => {
  const [state, setState] = useState({
    values: null,
  });
  const handleSubmit = values => {
    setState({ ...state, values });
  };

  return (
    <AuthWrapper>
      <div className="auth-contents">
        <Form name="forgotPass" onFinish={handleSubmit} layout="vertical">
          <Heading as="h3">Olvido su contraseña?</Heading>
          <p className="forgot-text">
            Ingresa la dirección de correo electrónico que usaste cuando te uniste y te enviaremos instrucciones para restablecer tu contraseña.
          </p>
          <Form.Item
            label="Correo electrónico"
            name="email"
            rules={[{ required: true, message: '¡Ingrese su correo electrónico!', type: 'email' }]}
          >
            <Input placeholder="name@example.com" />
          </Form.Item>
          <Form.Item>
            <Button className="btn-reset" htmlType="submit" type="primary" size="large">
              Send Reset Instructions
            </Button>
          </Form.Item>
          <p className="return-text">
            Regresar a <NavLink to="/">Autenticación</NavLink>
          </p>
        </Form>
      </div>
    </AuthWrapper>
  );
};

export default ForgotPassword;
