

import Logo from '../Components/Logo';
import LoginForm from '../Components/LoginForm';
import './Login.css';


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