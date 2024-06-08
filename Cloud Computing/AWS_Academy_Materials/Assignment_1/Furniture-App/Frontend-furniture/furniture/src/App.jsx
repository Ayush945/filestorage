import React from 'react'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import Homepage from './pages/Homepage'
import Productpage from './pages/Productpage'
import Cartpage from './pages/Cartpage'
import AddProductPage from './pages/AddProductPage'

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path='/' element={<Homepage />} />
          <Route path='/add-product' element={<AddProductPage />} />
          <Route path='/all-product' element={<Productpage />} />
          <Route path='/cart' element={<Cartpage />} />
        </Routes>
      </BrowserRouter>
    </>
  )
}

export default App