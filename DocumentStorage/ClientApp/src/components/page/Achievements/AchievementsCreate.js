import React, { Component} from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Row from 'react-bootstrap/Row';


export class AchievementsCreate extends Component {
    static displayName = AchievementsCreate.name;

    constructor(props) {
        super(props);
        this.state =
        {
            title: '',
            fullTitle: '',
            journalName:'',
            description: '',
            linkToSource: '',
            releaseDate: '',
            achievementType: '', 
            validated: false
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

        const form = event.currentTarget;

        if (form.checkValidity() === false) {
            event.preventDefault();
            event.stopPropagation();
        }
        else {
            this.createAchievementData();
        }

        this.setState({ validated: true });
    }


    render() {
        return (
            <Form noValidate onSubmit={this.handleSubmit} validated={ this.state.validated }>
                <Form.Group>
                    <Form.Label>Title</Form.Label>
                    <Form.Control required type="text" placeholder="Enter Title" name="title" value={this.state.title} onChange={this.onInputChange} />
                    <Form.Control.Feedback type="invalid">Can't be empty!</Form.Control.Feedback>
                </Form.Group>

                <Row className="mb-3">
                    <Form.Group md="8" as={ Col }>
                        <Form.Label>Full Title</Form.Label>
                        <Form.Control reqired as="textarea" type="text" rows={3} placeholder="Enter Full Title" name="fullTitle" value={this.state.fullTitle} onChange={this.onInputChange} />
                        <Form.Control.Feedback type="invalid">Can't be empty!</Form.Control.Feedback>
                    </Form.Group>
                    <Form.Group md="4" as={Col}>
                        <Form.Label>Description</Form.Label>
                        <Form.Control as="textarea" type="text" rows={3} placeholder="Enter Description" name="description" value={this.state.description} onChange={this.onInputChange} />
                    </Form.Group>
                </Row>
                <Form.Group>
                    <Form.Label>Journal/Conference/Location Name</Form.Label>
                    <Form.Control type="text" placeholder="Enter Journal Name" name="journalName" value={this.state.journalName} onChange={this.onInputChange} />
                </Form.Group>

                <Form.Group>
                    <Form.Label>Link To Source</Form.Label>
                    <Form.Control type="text" placeholder="Enter Link To Source" name="linkToSource" value={this.state.linkToSource} onChange={this.onInputChange} />
                </Form.Group>

                {/*Here must be Date*/}

                <Form.Group>
                    <Form.Label>Achievement Type</Form.Label>
                    <Form.Select aria-label="Select Achievement Type" name="achievementType" value={ this.state.achievementType } onChange={ this.onInputChange }>
                        <option value="0">Unknown</option>
                        <option value="1">Scopus</option>
                        <option value="2">RSCI</option>
                        <option value="3">International</option>
                        <option value="4">Russian</option>
                        <option value="5">University</option>
                    </Form.Select>
                </Form.Group>


                <Button variant="primary" type="submit" className="mt-5">
                    Submit
                </Button>
            </Form>
         );
    }

    async createAchievementData() {
        const formData = new FormData();
        formData.append('title', this.state.title);
        formData.append('fullTitle', this.state.fullTitle);
        formData.append('journalName', this.state.journalName);
        formData.append('description', this.state.description);
        formData.append('linkToSource', this.state.linkToSource);
        formData.append('releaseDate', this.state.releaseDate);
        formData.append('achievementType', this.state.achievementType);

        const response = await fetch("api/achievements/create",
            {
                method: 'POST',
                body: formData
            });

        const data = await response.json();
    }
}
