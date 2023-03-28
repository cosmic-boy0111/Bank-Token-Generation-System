import React, { useState } from 'react'
import '../Style/Login.css'

import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';

const Register = () => {

    const navigate = useNavigate();

    const gotoLogin = () => {
        navigate(`/login`);
    }

    const [formData, setFormData] = useState({
        AccountNumber : '',
        Name : '',
        Password : '',
        ConfirmPassword : '',
    })

    const handleChange = (e) => {

        var name = e.target.name
        var value = e.target.value

        setFormData({
            ...formData,
            [name] : value
        })

    }

    const submitForm = async () => {

        try {

            console.log('under submit 1');
            
            if(formData.Password !== formData.ConfirmPassword) return;
            console.log('under submit 2');

            const res = await fetch('https://localhost:44319/api/register/Register',{
                method: 'POST',
                headers : {
                    'Content-Type': 'application/json',
                },
                body : JSON.stringify({
                    AccountNumber : formData.AccountNumber,
                    Name : formData.Name,
                    Password : formData.Password
                })
            })

            const data = await res.json();
            console.log(data);

        } catch (error) {
            
        }

    }

    return (
        <div className='login_body' >
            <div className='login_div'>
                <h2 className='mb_1' >Register</h2>
                <TextField 
                    id="standard-basic" 
                    label="Account Number" 
                    variant="standard" 
                    name='AccountNumber'
                    onChange={handleChange}
                    style={{ width: '100%', marginBottom:'1rem' }} 
                />
                <TextField 
                    id="standard-basic" 
                    label="User Name" 
                    variant="standard"
                    name='Name'
                    onChange={handleChange} 
                    style={{ width: '100%', marginBottom:'1rem' }} 
                />
                <TextField
                    id="standard-password-input"
                    label="Password"
                    type="password"
                    autoComplete="current-password"
                    variant="standard"
                    name='Password'
                    onChange={handleChange}
                    style={{ width: '100%', marginBottom:'1rem' }} 
                />
                <TextField
                    id="standard-password-input"
                    label="Confirm Password"
                    type="password"
                    name='ConfirmPassword'
                    onChange={handleChange}
                    autoComplete="current-password"
                    variant="standard"
                    style={{ width: '100%', marginBottom:'1rem' }} 
                />
                <Button variant="contained" style={{ width: '100%', marginBottom:'1rem' }} onClick={submitForm} >Register</Button>
                <Button variant="text" style={{ width: '100%' }}  onClick={gotoLogin} >Login</Button>

            </div>
        </div>
    )
}

export default Register