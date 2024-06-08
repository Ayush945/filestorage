import React from 'react'
import Navbar from '../components/Navbar'

function Homepage() {
    return (
        <>
            <div>
                <Navbar />
            </div>
            <div>
                <h1 className='flex justify-center items-center min-h-screen text-4xl font-bold'>WELCOME TO FURNITURE</h1>
            </div>
        </>
    )
}

export default Homepage