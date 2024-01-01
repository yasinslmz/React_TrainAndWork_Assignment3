import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useSelector, useDispatch } from 'react-redux'
import { setCartBooks } from '../redux/products/cartBooks';
import { Link } from 'react-router-dom';
import { setUser } from '../redux/user/userLoginSlice';

export default function Login() {
    const [loginData, setLoginData] = useState({
        id: 0,
        email: '',
        password: '',
        firstName:'',
        lastName:'',
        agreeTerms:true,
        phone:'',
        billIds:[]

    });
    const navigate = useNavigate();
    const handleInputChange = (e) => {
        const { name, value } = e.target;

        setLoginData((prevData) => ({
            ...prevData,
            [name]: value,
        }));
    };

    const dispatch=useDispatch();

    const handleFormSubmit = (e) => {
        e.preventDefault();
        console.log('Login Data:', loginData);
    
        const url = "https://localhost:7247/api/Login/Login";
        fetch(url, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(loginData),
        })
            .then(response => {
                if (!response.ok) {
                    
                }
                return response.json();
            })
            .then(data => {
                if (data) {
                    console.log("Giriş başarılı:", data);
                    dispatch(setUser(data));
                    navigate('/');
                }
            })
            .catch(error => console.error("Hata meydana geldi:", error));
    };
    

    return (
        <div className="login">
            <div className="user-login-area mb-70 mt-5">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-12">
                            <div className="login-title text-center mb-30">
                                <h2>Login</h2>

                            </div>
                        </div>
                        <div className="offset-lg-3 col-lg-6 col-md-12 col-12">
                            <div className="login-form">
                                <form onSubmit={handleFormSubmit}>
                                    <div className="single-login">
                                        <label>
                                            Username or email<span>*</span>
                                        </label>
                                        <input
                                            type="text"
                                            name="email"
                                            value={loginData.email}
                                            onChange={handleInputChange}
                                        />
                                    </div>
                                    <div className="single-login">
                                        <label>
                                            Password <span>*</span>
                                        </label>
                                        <input
                                            type="password"
                                            name="password"
                                            value={loginData.password}
                                            onChange={handleInputChange}
                                        />
                                    </div>
                                    <div className="single-login single-login-2">
                                        <button className='btn btn-success' type="submit">Login</button>
                                    </div>
                                    <a href="#">Lost your password?</a>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}
