import axios from 'axios';

const API_URL = 'http://localhost:7027';

class UserService{
    register(user)
    {
        return axios.post('${API_URL}/api/account/register',user)
    }
    
}

export default new UserService();