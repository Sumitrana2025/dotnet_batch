import React from 'react';

const Contact = () => {
  return (
    <div className='container'>
      <div className='py-4'>
        <h1>Contact Page</h1>
        <form>
          <div class='form-group'>
            <label for='exampleInputName1'>Name</label>
            <input type='Name' class='form-control' id='exampleInputName1' />
          </div>
          <div class='form-group'>
            <label for='exampleInputEmail1'>Email address</label>
            <input
              type='email'
              class='form-control'
              id='exampleInputEmail1'
              aria-describedby='emailHelp'
            />
            <small id='emailHelp' class='form-text text-muted'>
              We'll never share your email with anyone else.
            </small>
          </div>
          <div class='form-group'>
            <label for='exampleInputMessage1'>Message</label>
            <input
              type='message'
              class='form-control'
              id='exampleInputMessage1'
              aria-describedby='messageHelp'
            />
            <small id='messageHelp' class='form-text text-muted'>
              Write your Message Above
            </small>
          </div>
          <button type='button' id='submit' class='btn btn-primary'>
            Submit
          </button>
        </form>
      </div>
    </div>
  );
};
export default Contact;
