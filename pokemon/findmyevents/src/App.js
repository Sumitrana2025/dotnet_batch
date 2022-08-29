import React from 'react';
import './App.css';
import '../node_modules/bootstrap/dist/css/bootstrap.css';
import Home from './components/pages/Home';
import About from './components/pages/About';
import Contact from './components/pages/Contact';
import Navbar from './components/layout/Navbar';
import NotFound from './components/pages/NotFound';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import AddEvent from './components/users/AddEvent';
import EditEvent from './components/users/EditEvent';
import User from './components/users/Event';

function App() {
  return (
    <Router>
      <div className='App'>
        <Navbar />
        <Routes>
          <Route path='/' element={<Home />} />
          <Route path='/about' element={<About />} />
          <Route path='/contact' element={<Contact />} />
          <Route path='/users/add' element={<AddEvent />} />
          <Route path='/users/edit/:id' element={<EditEvent />} />
          <Route path='/users/:id' element={<User />} />
          <Route path='*' element={<NotFound />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
