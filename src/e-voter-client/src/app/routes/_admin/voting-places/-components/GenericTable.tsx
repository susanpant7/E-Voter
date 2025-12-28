import React, { useState } from 'react';
import { ExpandCollapseIcon } from "../../../../../componenets/UI/ExpandCollapseIcon.tsx";

// --- Action Buttons Sub-Component ---
interface ActionButtonsProps<T> {
    item: T;
    onEdit?: (item: T) => void;
    onDelete?: (item: T) => void;
}

const ActionButtons = <T,>({ item, onEdit, onDelete }: ActionButtonsProps<T>) => (
    <div className="flex justify-end gap-2">
        {onEdit && (
            <button
                onClick={(e) => { e.stopPropagation(); onEdit(item); }}
                className="rounded bg-blue-100 px-3 py-1 text-xs font-medium text-blue-700 hover:bg-blue-200 transition-colors"
            >
                Edit
            </button>
        )}
        {onDelete && (
            <button
                onClick={(e) => { e.stopPropagation(); onDelete(item); }}
                className="rounded bg-red-100 px-3 py-1 text-xs font-medium text-red-700 hover:bg-red-200 transition-colors"
            >
                Delete
            </button>
        )}
    </div>
);

// --- Main Generic Table Component ---
interface Column<T> {
    header: string;
    key: keyof T;
}

interface GenericTableProps<T, SubT = any> {
    headers: Column<T>[];
    data: T[];
    onEdit?: (item: T) => void;
    onDelete?: (item: T) => void;
    onExpand?: (item: T, isExpanded: boolean) => void;
    // Sub-table configurations
    subTableHeaders?: Column<SubT>[];
    getSubTableData?: (item: T) => SubT[];
}

const GenericTable = <
    T extends { id: string | number },
    SubT extends { id: string | number }
>({
      headers,
      data,
      onEdit,
      onDelete,
      onExpand,
      subTableHeaders,
      getSubTableData,
  }: GenericTableProps<T, SubT>) => {
    // Store only the ID of the expanded row (null means all closed)
    const [expandedRowId, setExpandedRowId] = useState<string | number | null>(null);

    const toggleRow = (item: T) => {
        const isCurrentlyExpanded = expandedRowId === item.id;
        const nextId = isCurrentlyExpanded ? null : item.id;

        setExpandedRowId(nextId);

        if (onExpand) {
            onExpand(item, !isCurrentlyExpanded);
        }
    };

    const showActions = !!onEdit || !!onDelete;
    const isExpandable = !!subTableHeaders && !!getSubTableData;

    return (
        <div className="overflow-x-auto rounded-lg border border-gray-200 shadow-sm bg-white">
            <table className="min-w-full divide-y divide-gray-200 text-sm">
                <thead className="bg-gray-50">
                <tr>
                    {isExpandable && <th className="w-12 px-4 py-3"></th>}
                    {headers.map((col, index) => (
                        <th key={index} className="px-4 py-3 text-left font-semibold text-gray-900">
                            {col.header}
                        </th>
                    ))}
                    {showActions && <th className="px-4 py-3 text-right font-semibold text-gray-900">Actions</th>}
                </tr>
                </thead>

                <tbody className="divide-y divide-gray-100">
                {data.map((item) => {
                    const isExpanded = expandedRowId === item.id;

                    return (
                        <React.Fragment key={item.id}>
                            {/* Main Row */}
                            <tr className={`hover:bg-gray-50 transition-colors ${isExpanded ? 'bg-indigo-50/40' : ''}`}>
                                {isExpandable && (
                                    <td className="px-4 py-3">
                                        <button
                                            onClick={() => toggleRow(item)}
                                            className="focus:outline-none"
                                        >
                                            <ExpandCollapseIcon isExpanded={isExpanded} />
                                        </button>
                                    </td>
                                )}
                                {headers.map((col, index) => (
                                    <td key={index} className="whitespace-nowrap px-4 py-3 text-gray-700">
                                        {String(item[col.key])}
                                    </td>
                                ))}
                                {showActions && (
                                    <td className="whitespace-nowrap px-4 py-3 text-right">
                                        <ActionButtons item={item} onEdit={onEdit} onDelete={onDelete} />
                                    </td>
                                )}
                            </tr>

                            {/* Nested Table Row - rendered only if this specific row is expanded */}
                            {isExpandable && isExpanded && (
                                <tr>
                                    <td colSpan={headers.length + (showActions ? 1 : 0) + (isExpandable ? 1 : 0)} className="bg-gray-50 p-4">
                                        <div className="ml-8 border-l-4 border-indigo-400 pl-6 py-2">
                                            <h4 className="text-xs font-bold text-gray-400 uppercase tracking-widest mb-3">
                                                Details for {String(item[headers[0].key])}
                                            </h4>
                                            <GenericTable
                                                headers={subTableHeaders}
                                                data={getSubTableData(item)}
                                            />
                                        </div>
                                    </td>
                                </tr>
                            )}
                        </React.Fragment>
                    );
                })}
                </tbody>
            </table>
        </div>
    );
};

export default GenericTable;