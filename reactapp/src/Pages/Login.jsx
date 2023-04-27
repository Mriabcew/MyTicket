

import Logo from '../components/Logo';
import LoginForm from '../components/LoginForm';
import './CSS/Login.css';


const LoginPage = () => {
  return (
    <div className='LoginContainer'>
        <div className='LoginLogo'>
          <Logo/>
        </div>
        <div className='LoginForm'>
          <LoginForm/>
        </div>
   
   </div>
  );
};

export default LoginPage;