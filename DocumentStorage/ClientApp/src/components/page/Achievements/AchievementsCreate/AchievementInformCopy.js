import { useEffect, useState } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Row from 'react-bootstrap/Row';

// Необходимо продумать и реализовать механизм, когда при смене значения isCreated
// вызывается следующая страница. 

function AchievementInformCopy({ onCreatedId}) {
    const [formState, setFormState] = useState({
        loading: false,
        uid: null,
    });
    const [prop, setProp] = useState([{
        title: '',
        fullTitle: '',
        journalName: '',
        description: '',
        releaseDate: '',
        achievementType: '',
    }]);
    const [isValidated, setValidated] = useState(false);
    const [isCompleted, setCompleted] = useState(false);

    const handleCreated = (id) => {
        onCreatedId(id);
    }

    const createAchievementData = async () => {
        const formData = new FormData();
        formData.append('title', prop.title);
        formData.append('fullTitle', prop.fullTitle);
        formData.append('journalName', prop.journalName);
        formData.append('description', prop.description);
        formData.append('releaseDate', prop.releaseDate);
        formData.append('achievementType', prop.achievementType);

        const response = await fetch("api/achievements/create",
            {
                method: 'POST',
                body: formData
            });

        const data = await response.json();
        if (data != null) {
            //this.props.creationHandler(true);
        }

        //OnCreated("6681ca0d-11f3-4a92-9100-6cf6bef80717");
    };
    
    //useEffect(() => {
    //    const createAchievementData = async () => {
    //        const formData = new FormData();
    //        formData.append('title', prop.title);
    //        formData.append('fullTitle', prop.fullTitle);
    //        formData.append('journalName', prop.journalName);
    //        formData.append('description', prop.description);
    //        formData.append('releaseDate', prop.releaseDate);
    //        formData.append('achievementType', prop.achievementType);

    //        setFormState({ loading: true });

    //        const url = "api/achievements/create";
    //        axios.post(url, formData)
    //            .then((resp) => {
    //                if (resp.status === 200) {
    //                    setFormState({
    //                        loading: true,
    //                        uid: resp.data
    //                    });
    //                }
    //                else {
    //        setFormState({ loading: true });
    //        onCreatedId("6681ca0d-11f3-4a92-9100-6cf6bef80717");
    //        onPageNumberClick("2");
    //        }
    //    };

    //    if (isCompleted === true) {
    //        createAchievementData();
    //        onCreatedId("6681ca0d-11f3-4a92-9100-6cf6bef80717");
    //        onPageNumberClick("2");
    //    }

    //}, [setFormState]);

    const onInputChange = (event) => {
        setProp({
            [event.target.name]: event.target.value
        });
    }  


    const handleSubmit = (event) => {
        setValidated(true);

        const form = event.currentTarget;
        if (form.checkValidity() === false) {
            event.preventDefault();
            event.stopPropagation();
        }
        else {
            setCompleted(true);
            createAchievementData();
       
            //onPageNumberClick("2", prop);
        }

    }

    return (
        <Form noValidate onSubmit={handleSubmit} validated={isValidated}>
            <Form.Group>
                <Form.Label>Title</Form.Label>
                <Form.Control required type="text" placeholder="Enter Title" name="title" value={prop.title} onChange={onInputChange} />
                <Form.Control.Feedback type="invalid">Can't be empty!</Form.Control.Feedback>
            </Form.Group>

            <Row className="mb-3">
                <Form.Group md="8" as={Col}>
                    <Form.Label>Full Title</Form.Label>
                    <Form.Control required as="textarea" type="text" rows={3} placeholder="Enter Full Title" name="fullTitle" value={prop.fullTitle} onChange={onInputChange} />
                    <Form.Control.Feedback type="invalid">Can't be empty!</Form.Control.Feedback>
                </Form.Group>
                <Form.Group md="4" as={Col}>
                    <Form.Label>Description</Form.Label>
                    <Form.Control as="textarea" type="text" rows={3} placeholder="Enter Description" name="description" value={prop.description} onChange={onInputChange} />
                </Form.Group>
            </Row>
            <Form.Group>
                <Form.Label>Journal/Conference/Location Name</Form.Label>
                <Form.Control type="text" placeholder="Enter Journal Name" name="journalName" value={prop.journalName} onChange={onInputChange} />
            </Form.Group>

            <Form.Group>
                <Form.Label>Achievement Type</Form.Label>
                <Form.Select aria-label="Select Achievement Type" name="achievementType" value={prop.achievementType} onChange={onInputChange}>
                    <option value="0">Unknown</option>
                    <option value="1">Scopus</option>
                    <option value="2">RSCI</option>
                    <option value="3">International</option>
                    <option value="4">Russian</option>
                    <option value="5">University</option>
                </Form.Select>
            </Form.Group>

{/*            {(!isCreated) && (*/}
                <Button variant="primary" type="submit" className="mt-5">
                    Submit
                </Button>
{/*            )}*/}
        </Form>
    );
}
export default AchievementInformCopy;

//        async createAchievementData() {
//    const formData = new FormData();
//    formData.append('title', this.state.title);
//    formData.append('fullTitle', this.state.fullTitle);
//    formData.append('journalName', this.state.journalName);
//    formData.append('description', this.state.description);
//    formData.append('releaseDate', this.state.releaseDate);
//    formData.append('achievementType', this.state.achievementType);

//    const response = await fetch("api/achievements/create",
//        {
//            method: 'POST',
//            body: formData
//        });

//    const data = await response.json();
//    if (data != null) {
//        this.props.creationHandler(true);
//    }
//}