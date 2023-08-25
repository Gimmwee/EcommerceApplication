import React from 'react';
import {BrowserRouter as Router, Routes, Route} from 'react-router-dom';
import Login from './Login';
import Registration from './Registration';
import Dashboard from './users/Dashboard';
import Orders from './users/Orders';
import Profile from './users/Profile';
import Cart from './users/Cart';
import AdminDashboard from './admin/AdminDashBoard';
import AdminOrder from './admin/AdminOrder';
import CustomerList from './admin/CustomerList';
import Medicine from './admin/Medicine';
import Cart from './users/Cart';



export default function RouterPage(){
    return(
        <Router>
            <Routes>
                <Route path='/' element={<Login />} />
                <Route path='/registration' element={<Registration />} />
                <Route path='/dashboard' element={<Dashboard />} />
                <Route path='/myorders' element={<Orders />} />
                <Route path='/profile' element={<Profile />} />
                <Route path='/cart' element={<Cart />} />

                <Route path='/products' element={<MedicineDisplay />} />

                <Route path='/adminDashboard' element={<AdminDashboard />} />
                <Route path='/adminOrder' element={<AdminOrder />} />
                <Route path='/customerList' element={<CustomerList />} />
                <Route path='/medicine' element={<Medicine />} />
            </Routes>
        </Router>
    )
}