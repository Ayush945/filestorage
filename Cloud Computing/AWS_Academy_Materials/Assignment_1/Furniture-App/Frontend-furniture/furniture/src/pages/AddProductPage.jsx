import React, { useState } from 'react';
import Navbar from '../components/Navbar';
import 'tailwindcss/tailwind.css'; // Import the Tailwind CSS file
import axios from 'axios';
import baseUrl from '../components/baseUrl';

function AddProductPage() {
    const [message, setMessage] = useState(false);
    const [formData, setFormData] = useState({
        productName: '',
        productPrice: ''
    })
    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData((prevData) => ({
            ...prevData, [name]: value
        }))
    }

    const handleSubmit = async (e) => {
        e.preventDefault();
        const apiEndpoint = `${baseUrl}add-product`;
        console.log(apiEndpoint)
        try {
            const response = await axios.post(apiEndpoint, formData);
            console.log(response)
            setMessage(true);
        }
        catch (error) {
            console.error(error);
        }
    }
    return (
        <>
            <div>
                <Navbar />
            </div>

            <div className='min-h-screen flex justify-center items-center'>

                <form
                    onSubmit={handleSubmit}
                >
                    <h1 className="text-3xl font-bold mb-4">Add Product</h1>
                    <label className="block mb-2">Product Name:</label>
                    <input
                        type="text"
                        className="border border-gray-300 p-2 mb-4"
                        onChange={handleChange}
                        placeholder='Product Name'
                        name='productName'
                        value={formData.productName}
                        required
                    />
                    <label className="block mb-2">Product Price:</label>
                    <input
                        type="text"
                        className="border border-gray-300 p-2 mb-4"
                        onChange={handleChange}
                        placeholder='Product Price'
                        name='productPrice'
                        value={formData.productPrice}
                        required
                    />
                    <div>
                        <button
                            type="submit"
                            className="bg-blue-500 text-white py-2 px-4 rounded"
                        >
                            Submit
                        </button>
                    </div>
                    {message && (
                        <div className='text-green-600 mt-10'>
                            Product Added
                        </div>
                    )}
                </form>

            </div>
            <div>

            </div>
        </>
    );
}

export default AddProductPage;
