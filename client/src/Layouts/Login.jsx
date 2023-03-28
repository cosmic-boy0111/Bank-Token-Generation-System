import React from 'react'
import '../Style/Login.css'

import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';

const Login = () => {

    const navigate = useNavigate();

    const gotoRegister = () => {
        navigate(`/register`);
    }

    return (
        <div className='login_body' >
            <div className='login_div'>
                <h2 className='mb_1' >Login</h2>
                <TextField 
                    id="standard-basic" 
                    label="User Name" 
                    variant="standard" 
                    style={{ width: '100%', marginBottom:'1rem' }} 
                />
                <TextField
                    id="standard-password-input"
                    label="Password"
                    type="password"
                    autoComplete="current-password"
                    variant="standard"
                    style={{ width: '100%', marginBottom:'1rem' }} 
                />
                
                <Button variant="contained" style={{ width: '100%', marginBottom:'1rem' }} >Login</Button>
                <Button variant="text" style={{ width: '100%' }}  onClick={gotoRegister} >Register</Button>

            </div>
        </div>
    )
}

export default Login