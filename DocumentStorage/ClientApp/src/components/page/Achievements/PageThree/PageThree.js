import { useState } from 'react';
import "./PageThree.css";
//import Form from 'react-bootstrap/Form';
//import Button from 'react-bootstrap/Button';
//import Container from 'react-bootstrap/Container';
//import Row from 'react-bootstrap/Row';
//import Col from 'react-bootstrap/Col';


function PageThree() {
    const [serviceList, setServiceList] = useState([{ service: "" }]);

    const handleServiceChange = (e, index) => {
        const { name, value } = e.target;
        const list = [...serviceList];
        list[index][name] = value;
        setServiceList(list);
    };

    const handleServiceRemove = (index) => {
        const list = [...serviceList];
        list.splice(index, 1);
        setServiceList(list);
    };

    const handleServiceAdd = () => {
        setServiceList([...serviceList, { service: ""}])
    };

    return (
        <form className="App" autoComplete="off">
            <div className="form-field">
                <label htmlFor="service">Service(s)</label>
                {serviceList.map((singleService, index) => (
                    <div key={index} className="services">
                        <div className="first-division">
                            <input
                                name="service"
                                type="text"
                                id="service"
                                value={singleService.service}
                                onChange={(e) => handleServiceChange(e, index)}
                                required
                            />
                            {serviceList.length - 1 === index && serviceList.length < 4 && (
                                <button
                                    type="button"
                                    onClick={handleServiceAdd}
                                    className="add-btn"
                                >
                                    <span>Add a Service</span>
                                </button>
                            )}
                        </div>
                        <div className="second-division">
                            {serviceList.length !== 1 && (
                                <button
                                    type="button"
                                    onClick={() => handleServiceRemove(index)}
                                    className="remove-btn">
                                    <span>Remove</span>
                                </button>
                            )}
                        </div>
                    </div>
                ))}
            </div>
            <div className="output">
                <h2>Output</h2>
                {serviceList &&
                    serviceList.map((singleService, index) => (
                        <ul key={index}>
                            {singleService.service && <li>{singleService.service}</li>}
                        </ul>
                    ))}
            </div>
        </form>
    );
}

export default PageThree;

//export class PageThree extends Component {
//    static displayName = PageThree.name;

//    constructor(props) {
//        super(props);
//        this.state =
//        {

//        }

//        this.onInputChange = this.onInputChange.bind(this);
//        this.handleSubmit = this.handleSubmit.bind(this);
//    }

//    addInputField = () => {

//    }
//    onInputChange(event) {
//        this.setState({
//            [event.target.name]: event.target.value
//        });
//    }


//    handleSubmit(event) {

//    }


//    render() {
//        return (
//            <Form noValidate onSubmit={this.handleSubmit} validated={this.state.validated}>

//                <Container>
//                    <Row>
//                        <Col>
//                            <Form.Group controlId="formFile" className="mb-3">
//                                <Form.Label>File Achievements</Form.Label>
//                                <Form.Control type="file" />
//                            </Form.Group>
//                            <div>
//                                <Button variant="outline-primary" className="lg">
//                                    Add New File
//                                </Button>
//                            </div>
//                        </Col>
//                    </Row>
//                    <Button variant="primary" type="submit" className="mt-5">
//                        Submit
//                    </Button>
//                </Container>
//            </Form>
//        );
//    }

//    async createAchievementData() {

//    }
//}

//export default PageThree;