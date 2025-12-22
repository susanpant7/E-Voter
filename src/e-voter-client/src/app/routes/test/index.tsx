import { createFileRoute } from '@tanstack/react-router'
import {TextInput} from "../../../componenets/UI/TextInput.tsx";
import {useState} from "react";

export const Route = createFileRoute('/test/')({
  component: RouteComponent,
})


export function RouteComponent() {
  const [formValues, setFormValues] = useState({
    name: '',
    address: '',
    textInput: '',
  });

  const formFields = [
    { label: 'Name', key: 'name', required: true },
    { label: 'Address', key: 'address' },
    { label: 'Text Input', key: 'textInput', required: true },
  ];

  // Single generic handler
  const handleFormFieldOnChange = (key: string) => (event: React.ChangeEvent<HTMLInputElement>) => {
    const value = event.target.value;
    setFormValues((prev) => ({ ...prev, [key]: value }));
  };

  return (
      <div className="space-y-4 p-4">
        <h1>Hello "/test/"!</h1>

        {formFields.map((field) => (
            <TextInput
                key={field.key}
                label={field.label}
                value={formValues[field.key] || ''}
                required={field.required}
                onChange={handleFormFieldOnChange(field.key)} // curried function
            />
        ))}

        <pre className="mt-4 p-2 bg-gray-100 rounded">
        {JSON.stringify(formValues, null, 2)}
      </pre>
      </div>
  );
}