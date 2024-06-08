import React from 'react';
import { Link } from 'react-router-dom';

function Navbar() {
    return (
        <div className="lg:flex lg:justify-between lg:p-4 bg-gray-800 text-white">
            <div className="mb-4 lg:mb-0">
                <Link to={'/'}><h1 className="text-2xl font-bold cursor-pointer">FURNITURE</h1></Link>
            </div>

            <div className="flex flex-col lg:flex-row lg:space-x-5 text-xl">
                <Link to={'/'}><h1 className="mb-2 lg:mb-0 cursor-pointer">Home</h1></Link>
                <Link to={'/add-product'}><h1 className="mb-2 lg:mb-0 cursor-pointer">Add Product</h1></Link>
                <Link to={'/all-product'}><h1 className="mb-2 lg:mb-0 cursor-pointer">All Product</h1></Link>
                <Link to={'/cart'}><h1 className="cursor-pointer">Cart</h1></Link>
            </div>
        </div>
    );
}

export default Navbar;
