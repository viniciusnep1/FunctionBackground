import React from 'react';
import { Navbar, Nav, Form, Button,FormControl  } from 'react-bootstrap'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faUserCircle } from '@fortawesome/free-solid-svg-icons'

export default props => (
    <Navbar bg="light" expand="lg">
  <Navbar.Brand href="#home">Portal XPTO</Navbar.Brand>
  <Navbar.Toggle aria-controls="basic-navbar-nav" />
  <Navbar.Collapse id="basic-navbar-nav">
    <Nav className="mr-auto">
    </Nav>
    <Form inline className="center-block">
      <FormControl type="text" placeholder="Search" className="mr-sm-2" />
      <Button variant="outline-secondary">Search</Button>
    </Form>
    <FontAwesomeIcon icon={faUserCircle} size="2x" color="#808080"/>

  </Navbar.Collapse>
</Navbar>
)