import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';

export class CreateNewAuthor extends Component {
    static displayName = CreateNewAuthor.name;

    constructor(props) {
        super(props);
        this.state = {
            firstName: '',
            lastName: '',
            patronymic: '',
            email: ''
        }

        this.onInputChange = this.onInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);

    }

    onInputChange(event) {
        this.setState({
            [event.target.name]: event.target.value
        });
    }

    handleSubmit(event) {
        this.sendHousedata();
    }


    render() {
        return (
            <Form onSubmit={this.handleSubmit}>

                <Form.Group className="mb-3">
                    <Form.Label>Text Placeholder</Form.Label>
                    <Form.Control type="text" placeholder="Enter First Name" name="firstName" value={this.state.firstName} onChange={this.onInputChange} />
                    <Form.Text className="text-muted">
                        Test
                    </Form.Text>
                </Form.Group>

                <Form.Group className="mb-3">
                    <Form.Label>Text Placeholder</Form.Label>
                    <Form.Control type="text" placeholder="Enter Last Name" name="lastName" value={this.state.lastName} onChange={this.onInputChange} />
                    <Form.Text className="text-muted">
                        Test
                    </Form.Text>
                </Form.Group>

                <Form.Group className="mb-3">
                    <Form.Label>Text Placeholder</Form.Label>
                    <Form.Control type="text" placeholder="Enter Patronymic" name="patronymic" value={this.state.patronymic} onChange={this.onInputChange} />
                    <Form.Text className="text-muted">
                        Test
                    </Form.Text>
                </Form.Group>

                <Form.Group className="mb-3">
                    <Form.Label>Text Placeholder</Form.Label>
                    <Form.Control type="text" placeholder="Enter Email" name="email" value={this.state.email} onChange={this.onInputChange} />
                    <Form.Text className="text-muted">
                        Test
                    </Form.Text>
                </Form.Group>

                <Button variant="primary" size="lg" type="submit" className="mt-5">
                    Submit
                </Button>
            </Form>
        );
    }
    async sendHousedata() {
        const formData = new FormData();
        formData.append('firstName', this.state.firstName);
        formData.append('lastName', this.state.lastName);
        formData.append('patronymic', this.state.patronymic);
        formData.append('email', this.state.email);



        const response = await fetch("api/author/create",
            {
                method: 'POST',
                body: formData
            }).then(res => res.clone().json());

        const data = await response.json();
    }
}