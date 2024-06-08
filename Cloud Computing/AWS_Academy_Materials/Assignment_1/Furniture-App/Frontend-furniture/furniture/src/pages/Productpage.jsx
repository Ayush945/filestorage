import React, { useEffect, useState } from 'react';
import Navbar from '../components/Navbar';
import baseUrl from '../components/baseUrl';
import axios from 'axios';

function Productpage() {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const apiEndPoint = `${baseUrl}get-all-products`;
                const response = await axios.get(apiEndPoint);
                setProducts(response.data);
            } catch (error) {
                console.error(error);
            }
        };
        fetchData();
    }, []);

    const handleDelete = async (productId) => {
        try {
            const apiEndPoint = `${baseUrl}delete-product/${productId}`;
            await axios.delete(apiEndPoint);
            setProducts((prevProducts) =>
                prevProducts.filter((product) => product.productId !== productId)
            );
        } catch (error) {
            console.error(error);
        }
    };

    const handleCart = async (productId) => {
        try {
            const apiEndPoint = `${baseUrl}add-to-cart/${productId}`;
            await axios.post(apiEndPoint);
        } catch (error) {
            console.error(error);
        }
    }
    return (
        <>
            <div className="bg-gray-100">
                <Navbar />
            </div>
            <div className="container mx-auto my-8">
                <h1 className="text-3xl font-bold mb-4 text-gray-800">All Products</h1>
                <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-4">
                    {products.map((product) => (
                        <div key={product.productId} className="bg-white p-4 rounded-md shadow-md">
                            <h2 className="text-lg font-semibold mb-2 text-blue-600">{product.productName}</h2>
                            <h2 className="text-gray-700">${product.productPrice}</h2>
                            <button
                                className="bg-blue-500 text-white py-2 px-4 rounded mr-2"
                                onClick={() => handleCart(product.productId)}
                            >
                                Add To Cart
                            </button>
                            <button
                                className="bg-red-500 text-white py-2 px-4 rounded"
                                onClick={() => handleDelete(product.productId)}
                            >
                                Delete
                            </button>
                        </div>
                    ))}
                </div>
            </div>
        </>
    );
}

export default Productpage;
