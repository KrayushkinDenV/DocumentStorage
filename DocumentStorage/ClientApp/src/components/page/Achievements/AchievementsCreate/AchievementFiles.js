import { useState } from 'react';
import "./AchievementFiles.css";
import Form from 'react-bootstrap/Form';


function AchievementFiles() {
    const [fileList, setFileList] = useState([{ description: "",selectedFile: null }]);

    const handleDescriptionChange = (e, index) => {
        const _description = e.target.value;
        const _fileList = [...fileList];
        _fileList[index].description = _description;
        setFileList(_fileList);
    };

    const handleFileChange = (e, index) => {
        const file = e.target.files[0];
        const _fileList = [...fileList];
        _fileList[index].selectedFile = file;
        setFileList(_fileList);
    };

    const handleFileRemove = (index) => {
        const _fileList = [...fileList];
        _fileList.splice(index, 1);
        setFileList(_fileList);
    };

    const handleFileAdd = () => {
        setFileList([...fileList, { description: "", selectedFile: null }]);
    };

    const handleUploadFile = (index) => {
        uploadFile(fileList[index].selectedFile);
    };

    async function uploadFile(file){
        const formData = new FormData();

        formData.append('file', file);

        const response = await fetch("api/achievements/upload",
            {
                method: 'POST',
                body: formData
            });

        const data = await response.json();
    }

    return (
        <form className="App" autoComplete="off">
            <div className="form-field">
                <label htmlFor="service">Service(s)</label>
                {fileList.map((singleFile, index) => (
                    <div key={index} className="services">
                        <div className="first-division">
                            <input
                                name="description"
                                type="text"
                                id="description"
                                value={singleFile.description}
                                onChange={(e) => handleDescriptionChange(e, index)}
                                required
                            />
                            <Form.Group controlId="formFile">
                                <Form.Control type="file" onChange={ (e) => handleFileChange(e, index)} />
                            </Form.Group>
                        </div>
                        <div >
                            <div className="second-division">
                                {fileList[index].selectedFile !== null && (
                                    <button
                                        type="button"
                                        onClick={() => handleFileRemove(index)}
                                        className="remove-btn">
                                        <span>Remove</span>
                                    </button>
                                )}
                            </div>
                            <div className="third-division">
                                {fileList[index].selectedFile !== null && (
                                    <button
                                        type="button"
                                        onClick={() => handleUploadFile(index)}
                                        className="upload-btn">
                                        <span>Upload</span>
                                    </button>
                                )}
                            </div>
                        </div>
                    </div>
                ))}
                {fileList.length < 10 && (
                    <button
                        type="button"
                        onClick={handleFileAdd}
                        className="add-btn"
                    >
                        <span>Add a Service</span>
                    </button>
                )}
            </div>
            <div className="output">
                <h2>Output</h2>
                {fileList &&
                    fileList.map((singleFile, index) => (
                        <ul key={index}>
                            {singleFile.description && <li>{singleFile.description}</li>}
                        </ul>
                    ))}
            </div>
        </form>
    );

}
export default AchievementFiles;
