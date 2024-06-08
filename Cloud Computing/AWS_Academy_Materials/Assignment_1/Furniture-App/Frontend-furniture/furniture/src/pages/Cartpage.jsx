import React, { useEffect, useState } from 'react';
import Navbar from '../components/Navbar';
import baseUrl from '../components/baseUrl';
import axios from 'axios';

function Cartpage() {
    const [cartData, setCartData] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const apiEndPoint = `${baseUrl}get-cart-item`;
                const response = await axios.get(apiEndPoint);
                setCartData(response.data);
            } catch (error) {
                console.error(error);
            }
        };
        fetchData();
    }, []);

    const handleRemove = async (cartItemId) => {
        try {
            const apiEndPoint = `${baseUrl}delete-from-cart/${cartItemId}`;
            await axios.delete(apiEndPoint);

            // Update state by filtering out the removed cart item
            setCartData((prevData) =>
                prevData.filter((cartData) => cartData.cartItemId !== cartItemId)
            );
        } catch (error) {
            console.error(error);
        }
    };

    return (
        <>
            <div className="bg-gray-100">
                <Navbar />
            </div>
            <div className="container mx-auto my-8">
                {cartData.map((cart) => (
                    <div key={cart.cartItemId} className="bg-white p-4 rounded-md shadow-md mb-4">
                        <h1 className="text-lg font-semibold mb-2 text-blue-600">
                            {cart.product.productName}
                        </h1>
                        <h1 className="text-gray-700">${cart.product.productPrice}</h1>
                        <button
                            onClick={() => handleRemove(cart.cartItemId)}
                            className="bg-red-500 text-white py-2 px-4 rounded mt-2"
                        >
                            Remove
                        </button>
                    </div>
                ))}
            </div>
        </>
    );
}

export default Cartpage;
