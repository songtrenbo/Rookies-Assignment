import React, { InputHTMLAttributes } from 'react';
import { useField } from 'formik';
import { Form } from 'react-bootstrap';

const SelectField = (props) => {
    const [field, { error, touched, value }, { setValue }] = useField(props);

    const { name, options, label, isrequired } = props;

    const handleChange = (e) => {
        setValue(e.target.value)
    };

    return (
        <>
            <div className="mb-3 row">
                <label className="col-4 col-form-label d-flex">
                    {label}
                    {isrequired && (
                        <div className="invalid ml-1">(*)</div>
                    )}
                </label>

                <div className="col">
                    <select className="custom-select  form-control" onChange={handleChange}>
                        <option selected hidden>Open this select menu</option>
                        {
                            options.map(({ label: optionLabel, value: optionValue }) => (
                                <option value={optionValue} selected = {optionValue === value}>
                                    {optionLabel}
                                </option>
                            ))
                        }
                    </select>
                </div>
            </div>
        </>
    );
};
export default SelectField;
